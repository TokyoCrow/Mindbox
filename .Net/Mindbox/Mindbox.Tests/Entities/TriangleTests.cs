using Mindbox.Entities;
using Xunit;

namespace Mindbox.Tests.Entities
{
    /// <summary>
    /// Тесты для <see cref="Triangle"/>
    /// </summary>
    public class TriangleTests
    {
        /// <summary>
        /// Создание неправильного треугольника
        /// Должен бросить эксепшен
        /// </summary>
        [Fact]
        public void CreateIncorrectTriangle_ShouldThrowException()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 1, 2));
        }

        /// <summary>
        /// Получение площади треугольника
        /// Должен вернуть площадь
        /// </summary>
        [Fact]
        public void GetSquare_ShouldReturnSquare()
        {
            var triangle = new Triangle(3, 4, 5);

            var square = triangle.GetSquare();

            Assert.Equal(6, square);
        }



        /// <summary>
        /// Проверить является ли треугольник прямоугольным
        /// Должен подтвердить
        /// </summary>
        [Fact]
        public void IsRightAngledTriangle_ShouldReturnTrue()
        {
            var triangle = new Triangle(3, 4, 5);

            var isRightAngledTriangle = triangle.IsRightAngledTriangle();

            Assert.True(isRightAngledTriangle);
        }
    }
}