package net.ravendb.Indexes;

import net.ravendb.client.documents.DocumentStore;
import net.ravendb.client.documents.IDocumentStore;
import net.ravendb.client.documents.indexes.AbstractIndexCreationTask;
import net.ravendb.client.documents.indexes.FieldIndexing;
import net.ravendb.client.documents.queries.Query;
import net.ravendb.client.documents.session.IDocumentSession;

import java.text.DateFormat;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;
import java.time.temporal.TemporalUnit;
import java.util.Date;
import java.util.List;

public class Map {

    /*
    //region indexes_1
    public static class Employees_ByFirstAndLastName extends AbstractIndexCreationTask {
        // ...
    }
    //endregion
    */

    public static class Employees_ByFirstAndLastName extends AbstractIndexCreationTask {
        //region indexes_2
        public Employees_ByFirstAndLastName() {
            map = "docs.Employees.Select(employee => new { " +
                "    firstName = employee.firstName, " +
                "    lastName = employee.lastName " +
                "})";
        }
        //endregion
    }

    //region indexes_7
    public static class Employees_ByFullName extends AbstractIndexCreationTask {
        public static class Result {
            private String fullName;

            public String getFullName() {
                return fullName;
            }

            public void setFullName(String fullName) {
                this.fullName = fullName;
            }
        }

        public Employees_ByFullName() {
            map = "docs.Employees.Select(employee => new { " +
                "    fullName = (employee.firstName + \" \") + employee.lastName " +
                "})";
        }
    }
    //endregion

    //region indexes_1_0
    public static class Employees_ByYearOfBirth extends AbstractIndexCreationTask {
        public static class Result {
            private int yearOfBirth;

            public int getYearOfBirth() {
                return yearOfBirth;
            }

            public void setYearOfBirth(int yearOfBirth) {
                this.yearOfBirth = yearOfBirth;
            }
        }

        public Employees_ByYearOfBirth() {
            map = "docs.Employees.Select(employee => new { " +
                "    yearOfBirth = employee.birthday.year " +
                "})";
        }
    }
    //endregion

    //region indexes_1_2
    public static class Employees_ByBirthday extends AbstractIndexCreationTask {
        public static class Result {
            private Date birthday;

            public Date getBirthday() {
                return birthday;
            }

            public void setBirthday(Date birthday) {
                this.birthday = birthday;
            }
        }

        public Employees_ByBirthday() {
            map = "docs.Employees.Select(employee => new { " +
                "    birthday = employee.birthday " +
                "})";
        }
    }
    //endregion

    //region indexes_1_4
    public static class Employees_ByCountry extends AbstractIndexCreationTask {
        public static class Result {
            private String country;

            public String getCountry() {
                return country;
            }

            public void setCountry(String country) {
                this.country = country;
            }
        }

        public Employees_ByCountry() {
            map = "docs.Employees.Select(employee => new { " +
                "    country = employee.address.country " +
                "})";
        }
    }
    //endregion

    //region indexes_1_6
    public static class Employees_Query extends AbstractIndexCreationTask {
        public static class Result {
            private String[] query;

            public String[] getQuery() {
                return query;
            }

            public void setQuery(String[] query) {
                this.query = query;
            }
        }

        public Employees_Query() {
            map = "docs.Employees.Select(employee => new { " +
                "    query = new [] { employee.firstName, employee.lastName, employee.title, employee.address.city } " +
                "})";
            index("query", FieldIndexing.SEARCH);
        }
    }
    //endregion

    private static class Employee {

    }

    public Map() {
        try (IDocumentStore store = new DocumentStore()) {
            try (IDocumentSession session = store.openSession()) {
                //region indexes_4
                List<Employee> employees1 = session.query(Employee.class, Employees_ByFirstAndLastName.class)
                    .whereEquals("firstName", "Robert")
                    .toList();

                List<Employee> employees2 = session.query(Employee.class, Query.index("Employees/ByFirstAndLastName"))
                    .whereEquals("firstName", "Robert")
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_8
                // notice that we're 'cheating' here
                // by marking result type in 'query' as 'Employees_ByFullName.Result'
                // and changing type using 'ofType' before sending query to server
                List<Employee> employees = session
                    .query(Employees_ByFullName.Result.class, Employees_ByFullName.class)
                    .whereEquals("fullName", "Robert King")
                    .ofType(Employee.class)
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_9
                List<Employee> employees = session
                    .advanced()
                    .documentQuery(Employee.class, Employees_ByFullName.class)
                    .whereEquals("fullName", "Robert King")
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_6_1
                List<Employee> employees = session
                    .query(Employees_ByYearOfBirth.Result.class, Employees_ByYearOfBirth.class)
                    .whereEquals("yearOfBirth", 1963)
                    .ofType(Employee.class)
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_5_1
                LocalDate startDate = LocalDate.of(1963, 1, 1);
                LocalDate endDate = startDate.plusYears(1).minus(1, ChronoUnit.MILLIS);
                List<Employee> employees = session
                    .query(Employees_ByBirthday.Result.class, Employees_ByBirthday.class)
                    .whereBetween("birthday", startDate, endDate)
                    .ofType(Employee.class)
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_7_1
                List<Employee> employees = session
                    .query(Employees_ByCountry.Result.class, Employees_ByCountry.class)
                    .whereEquals("country", "USA")
                    .ofType(Employee.class)
                    .toList();
                //endregion
            }

            try (IDocumentSession session = store.openSession()) {
                //region indexes_1_7
                List<Employee> employees = session
                    .query(Employees_Query.Result.class, Employees_Query.class)
                    .search("query", "John Doe")
                    .ofType(Employee.class)
                    .toList();
                //endregion
            }

        }
    }

}
