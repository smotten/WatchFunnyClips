using System;
using System.Collections.Generic;
using System.Linq;
using WatchFunnyClips;
using WatchFunnyClips.Controllers;
using WatchFunnyClips.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace WatchFunnyClipsTests
{
    public class UnitTest
    {
      
        [Fact]
        public void TestIndexMethodReturnsObjects()
        {
            // Arrange
            var mockRepo = new Mock<IGenreClipsRepository>();
            mockRepo.Setup(repo => repo.Get())
                .Returns(DataTestService.GetTestGenreClips);
            var controller = new GenreClipsController(mockRepo.Object);

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<GenreClips>>(
                viewResult.ViewData.Model);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public void CreatePost_ReturnsViewWithGenreClips_WhenModelStateIsInvalid()
        {
            // Arrange
            var mockRepo = new Mock<IGenreClipsRepository>();
            var controller = new GenreClipsController(mockRepo.Object);

            controller.ModelState.AddModelError("GenreName", "Required");
            var genreClips = new GenreClips() { GenreName = ""};

            // Act
            var result = controller.Create(genreClips);

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<GenreClips>(viewResult.ViewData.Model);
            Assert.IsType<GenreClips>(model);
        }

        [Fact]
        public void CreatePost_SaveThroughRepository_WhenModelStateIsValid()
        {
            // Arrange
            var mockRepo = new Mock<IGenreClipsRepository>();
            mockRepo.Setup(repo => repo.Save(It.IsAny<GenreClips>()))
                //.Returns(Task.CompletedTask)
                .Verifiable();
            var controller = new GenreClipsController(mockRepo.Object);
            GenreClips g = new GenreClips()
            {
                GenreName = "Animal",
                
            };

            // Act
            var result = controller.Create(g);

            // Assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Null(redirectToActionResult.ControllerName);
            Assert.Equal("Index", redirectToActionResult.ActionName);
            mockRepo.Verify();
        }
    }
}