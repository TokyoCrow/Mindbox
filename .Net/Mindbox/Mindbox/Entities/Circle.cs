using Mindbox.Abstractions;
using System;

namespace Mindbox.Entities
{
    /// <summary>
    /// Фигура: Круг
    /// </summary>
    public class Circle : IFigure
    {
        private double _radius;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
            => Radius = radius;

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius
        {
            get => _radius;
            set
            {
                if (value <= 0)
                    throw new Exception("Радиус должен быть положительным числом");

                _radius = value;
            }
        }

        /// <inheritdoc/>
        public double GetSquare()
            => Math.PI * Math.Pow(Radius, 2);
    }
}
