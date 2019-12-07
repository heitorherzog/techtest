﻿using Xunit;
using TechTest;
using FluentAssertions;
using Application;

namespace TechTestXUnitTest
{
   public class ApplicationContextTest
    {
        
        [Theory]
        [InlineData("IRELAND", "1", "1")]
        [InlineData("ireland", "1", "2")]
        [InlineData("germany", "10", "20")]
        public void Should_Interpret_Return_UserInterpreted_True(string employeelocation, string srthoursworked, string srthourlyrate)
        {
            // arrange
            var input = new UserInput()
            {
                EmployeesLocation = employeelocation,
                StrHoursRate = srthourlyrate,
                StrHoursWorked = srthoursworked
            };
            var app = new ApplicationContext();
            UserInterpreted result;

            // act
            result = app.Interpret(input);

            // assert
            result.Should().NotBeNull();
            result.isValid.Should().BeTrue();
        }

        [Theory]
        [InlineData("LAND", "1", "1")]
        [InlineData("ireland", "x", "2")]
        [InlineData("germany", "10", "20..")]
        public void Should_Interpret_Return_UserInterpreted_False(string employeelocation, string srthoursworked, string srthourlyrate)
        {
            // arrange
            var input = new UserInput()
            {
                EmployeesLocation = employeelocation,
                StrHoursRate = srthourlyrate,
                StrHoursWorked = srthoursworked
            };
            var app = new ApplicationContext();
            UserInterpreted result;

            // act
            result = app.Interpret(input);

            // assert
            result.Should().NotBeNull();
            result.isValid.Should().BeFalse();
        }
    }
}
