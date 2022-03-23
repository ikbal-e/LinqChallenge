using FluentAssertions;
using LinqChallenge.API.Controllers;
using LinqChallenge.API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using static LinqChallenge.API.Controllers.ChallengesController;

namespace LinqChallenge.Tests
{
    public class ChallengeTests
    {
        [Fact]
        public void Challenge_1_Test()
        {
            var challangesController = new ChallengesController();

            var result = (List<string>)((OkObjectResult)challangesController.Challenge_1()).Value;

            result.Count.Should().Be(4);
            result.Should().Contain("Ankara");
            result.Should().Contain("Mersin");
            result.Should().Contain("Adana");
            result.Should().Contain("Antalya");
        }

        [Fact]
        public void Challenge_2_Test()
        {
            var challangesController = new ChallengesController();

            var result = (List<ContactInformation>)((OkObjectResult)challangesController.Challenge_2()).Value;

            result.Count.Should().Be(5);
            result.Should().Contain(x => x.Id == 1);
            result.Should().Contain(x => x.Id == 2);
            result.Should().Contain(x => x.Id == 3);
            result.Should().Contain(x => x.Id == 4);
            result.Should().Contain(x => x.Id == 5);
        }

        [Fact]
        public void Challenge_3_Test()
        {
            var challangesController = new ChallengesController();

            var result = (List<LocationDto>)((OkObjectResult)challangesController.Challenge_3()).Value;

            result.Count.Should().Be(4);
            result.Should().Contain(x => x.Name == "Ankara" && x.PersonCount == 1 && x.PhoneNumberCount == 1);
            result.Should().Contain(x => x.Name == "Mersin" && x.PersonCount == 1 && x.PhoneNumberCount == 0);
            result.Should().Contain(x => x.Name == "Adana" && x.PersonCount == 1 && x.PhoneNumberCount == 0);
            result.Should().Contain(x => x.Name == "Antalya" && x.PersonCount == 2 && x.PhoneNumberCount == 2);
        }


        [Fact]
        public void Challenge_4_Test()
        {
            var challangesController = new ChallengesController();

            var result = (List<int>)((OkObjectResult)challangesController.Challenge_4()).Value;

            result.Count.Should().Be(5);
            result.Should().NotContain(-10);
        }

        [Fact]
        public void Challenge_5_Test()
        {
            var challangesController = new ChallengesController();

            var result = (string)((OkObjectResult)challangesController.Challenge_5()).Value;

            result.Should().Be("e");
        }
    }
}