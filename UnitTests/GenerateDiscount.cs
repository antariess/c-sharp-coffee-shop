using System.Collections.Generic;
using CoffeeShopClasses;

namespace ClassesTests
{
    public class CustomerTests
    {
        [Fact]
        public void CustomerHasExpectedBehaviours()
        {

            Customer willCustomer = new Customer();
            willCustomer.FullName = "Will";
            string customerName = willCustomer.FullName;
            Guid customerId = willCustomer.Id;
            //// arrange
            var testCustomer = new Customer("Freddie");

            //// act
            var discount = testCustomer.GenerateDiscount();

            //// assert
            Assert.Equal("The customer's name is Freddie", testCustomer.FullName);
            Assert.Equal(0, discount);
        }

        [Fact]
        public void StudentHasExpectedBehaviour()
        {
            // arrange
            var testStudent = new Student("Moly");

            // act
            var discount = testStudent.GenerateDiscount();

            // assert
            Assert.Equal("The customer's name is Moly", testStudent.FullName);
            Assert.Equal(3, testStudent.Attendance);
            Assert.Equal(4, discount);
        }

        [Fact]
        public void TutorHasExpectedBehaviour()
        {
            // arrange
            var testTutor = new Tutor("Zusa");

            // act
            var discount = testTutor.GenerateDiscount();

            // assert
            Assert.Equal("The customer's name is Zusa", testTutor.FullName);
            Assert.Equal(6, testTutor.StudentSatisfaction);
            Assert.Equal(7, discount);
        }

        [Fact]
        public void CanIterateOverAll()
        {
            // arrange
            var testTutor = new Tutor("Zusa");
            var testStudent = new Student("Moly");
            var testCustomer = new Customer("Freddie");

            var customers = new List<Customer> { testCustomer, testStudent, testTutor };

            // act
            var custDiscount = customers[0].GenerateDiscount();
            var studentDiscount = customers[1].GenerateDiscount();
            var facultyDiscount = customers[2].GenerateDiscount();

            // assert
            Assert.Equal(0, custDiscount);
            Assert.Equal(4, studentDiscount);
            Assert.Equal(7, facultyDiscount);
        }
    }
}
