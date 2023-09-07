using Mindbox.Entities;
using Xunit;

namespace Mindbox.Tests.Entities
{
    /// <summary>
    /// Тесты для <see cref="Circle"/>
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Создание неправильного круга
        /// Должен бросить эксепшен
        /// </summary>
        [Fact]
        public void CreateIncorrectCircle_ShouldThrowException()
        {
            Assert.Throws<Exception>(() => new Circle(-2));
        }

        /// <summary>
        /// Получение площади круга
        /// Должен вернуть площадь
        /// </summary>
        [Fact]
        public void GetSquare_ShouldReturnSquare()
        {
            var circle = new Circle(3);

            var square = circle.GetSquare();

            Assert.Equal(28.274333882308138, square);
        }
    }
}