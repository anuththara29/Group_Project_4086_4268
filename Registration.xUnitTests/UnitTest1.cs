using FluentAssertions;
using Registration.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Registration.xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void User_Id_Should_Have_KeyAttribute()
        {
            var propertyInfo = typeof(User).GetProperty("Id");
            var attributes = propertyInfo.GetCustomAttributes(true);

            attributes.Should().Contain(attr => attr.GetType() == typeof(KeyAttribute));
        }

        [Fact]
        public void User_Username_Should_Have_RequiredAttribute()
        {
            var propertyInfo = typeof(User).GetProperty("Username");
            var attributes = propertyInfo.GetCustomAttributes(true);

            attributes.Should().Contain(attr => attr.GetType() == typeof(RequiredAttribute));
        }

        [Fact]
        public void User_Username_Should_Have_StringLengthAttribute_With_MaxLength_50()
        {
            var propertyInfo = typeof(User).GetProperty("Username");
            var stringLengthAttribute = propertyInfo.GetCustomAttribute<StringLengthAttribute>();

            stringLengthAttribute.Should().NotBeNull();
            stringLengthAttribute.MaximumLength.Should().Be(50);
        }

        [Fact]
        public void User_Password_Should_Have_RequiredAttribute()
        {
            var propertyInfo = typeof(User).GetProperty("Password");
            var attributes = propertyInfo.GetCustomAttributes(true);

            attributes.Should().Contain(attr => attr.GetType() == typeof(RequiredAttribute));
        }

        [Fact]
        public void User_Password_Should_Have_StringLengthAttribute_With_MaxLength_50()
        {
            var propertyInfo = typeof(User).GetProperty("Password");
            var stringLengthAttribute = propertyInfo.GetCustomAttribute<StringLengthAttribute>();

            stringLengthAttribute.Should().NotBeNull();
            stringLengthAttribute.MaximumLength.Should().Be(50);
        }

        [Fact]
        public void User_Role_Should_Have_RequiredAttribute()
        {
            var propertyInfo = typeof(User).GetProperty("Role");
            var attributes = propertyInfo.GetCustomAttributes(true);

            attributes.Should().Contain(attr => attr.GetType() == typeof(RequiredAttribute));
        }

        [Fact]
        public void User_Role_Should_Have_StringLengthAttribute_With_MaxLength_20()
        {
            var propertyInfo = typeof(User).GetProperty("Role");
            var stringLengthAttribute = propertyInfo.GetCustomAttribute<StringLengthAttribute>();

            stringLengthAttribute.Should().NotBeNull();
            stringLengthAttribute.MaximumLength.Should().Be(20);
        }
    }
}