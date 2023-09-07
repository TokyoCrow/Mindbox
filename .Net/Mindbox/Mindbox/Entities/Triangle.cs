using Mindbox.Abstractions;
using System;

namespace Mindbox.Entities
{
    /// <summary>
    /// Фигура: Треугольник
    /// </summary>
    public class Triangle : IFigure
    {
        private double _edgeA;
        private double _edgeB;
        private double _edgeC;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="edgeA">Сторона А</param>
        /// <param name="edgeB">Сторона B</param>
        /// <param name="edgeC">Сторона C</param>
        public Triangle(double edgeA, double edgeB, double edgeC)
        {
            if(!IsTriangle(edgeA, edgeB, edgeC))
                throw new Exception($"Треугольника со сторонами: {edgeA} {edgeB} {edgeC} - не существует");

            EdgeA = edgeA;
            EdgeB = edgeB;
            EdgeC = edgeC;
        }



        /// <summary>
        /// Сторона А
        /// </summary>
        public double EdgeA
        {
            get => _edgeA;
            set
            {
                if (value <= 0)
                    throw new Exception("'Сторона А' должена быть положительным числом");

                if (_edgeB > 0 && _edgeC > 0 && !IsTriangle(value, _edgeB, _edgeC))
                    throw new Exception($"Треугольника со сторонами: {value} {_edgeB} {_edgeC} - не существует");

                _edgeA = value;
            }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double EdgeB
        {
            get => _edgeB;
            set
            {
                if (value <= 0)
                    throw new Exception("'Сторона B' должена быть положительным числом");

                if (_edgeA > 0 && _edgeC > 0 && !IsTriangle(_edgeA, value, _edgeC))
                    throw new Exception($"Треугольника со сторонами: {_edgeA} {value} {_edgeC} - не существует");

                _edgeB = value;
            }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double EdgeC
        {
            get => _edgeC; 
            set
            {
                if (value <= 0)
                    throw new Exception("'Сторона C' должена быть положительным числом");

                if (_edgeA > 0 && _edgeB > 0 && !IsTriangle(_edgeA, _edgeB, value))
                    throw new Exception($"Треугольника со сторонами: {_edgeA} {_edgeB} {value} - не существует");

                _edgeC = value;
            }
        }

        /// <inheritdoc/>
        public double GetSquare()
        {
            var halfPerimetr = (EdgeA + EdgeB + EdgeC) / 2;

            return Math.Sqrt(halfPerimetr * (halfPerimetr - EdgeA) * (halfPerimetr - EdgeB) * (halfPerimetr - EdgeC));
        }

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        /// <returns>Является ли треугольник прямоугольным</returns>
        public bool IsRightAngledTriangle()
        {
            var biggerEdge = Math.Max(Math.Max(EdgeA, EdgeB), EdgeC);

            return (Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2) - Math.Pow(biggerEdge, 2)) == Math.Pow(biggerEdge, 2);
        }

        private bool IsTriangle(double edgeA, double edgeB, double edgeC)
            => edgeA + edgeB > edgeC 
            && edgeA + edgeC > edgeB 
            && edgeB + edgeC > edgeA; 
    }
}
