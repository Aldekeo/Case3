using System;
using System.Collections.Generic;
using System.Threading;

namespace TetrisGame
{
    public class Shape
    {
        private int[,] shapeMatrix;
        public int Row { get; set; }
        public int Col { get; set; }

        public Shape(int[,] matrix)
        {
            shapeMatrix = matrix;
            Row = 0;
            Col = 3;
        }

        public int[,] ShapeMatrix
        {
            get { return shapeMatrix; }
        }

        public static List<Shape> GetAllShapes()
        {
            return new List<Shape>
            {
                new Shape(new int[,]
                {
                    { 1, 1, 1, 1 }
                }),
                new Shape(new int[,]
                {
                    { 1, 1 },
                    { 1, 1 }
                }),
                new Shape(new int[,]
                {
                    { 0, 1, 0 },
                    { 1, 1, 1 }
                }),
                new Shape(new int[,]
                {
                    { 1, 0 },
                    { 1, 0 },
                    { 1, 1 }
                }),
                new Shape(new int[,]
                {
                    { 0, 1 },
                    { 0, 1 },
                    { 1, 1 }
                }),
                new Shape(new int[,]
                {
                    { 0, 1, 1 },
                    { 1, 1, 0 }
                }),
                new Shape(new int[,]
                {
                    { 1, 1, 0 },
                    { 0, 1, 1 }
                })
            };
        }

        public void Rotate()
        {
            int rowCount = shapeMatrix.GetLength(0);
            int colCount = shapeMatrix.GetLength(1);
            int[,] rotatedMatrix = new int[colCount, rowCount];

            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < colCount; col++)
                {
                    rotatedMatrix[col, rowCount - 1 - row] = shapeMatrix[row, col];
                }
            }

            shapeMatrix = rotatedMatrix;
        }

        public void MoveDown()
        {
            Row++;
        }

        public void MoveLeft()
        {
            Col--;
        }

        public void MoveRight()
        {
            Col++;
        }
    }

    public class GameField
    {
        private int[,] fieldMatrix;
        private Shape currentShape;
        private int score;

        public GameField(int rows, int cols)
        {
            fieldMatrix = new int[rows, cols];
            score = 0;
        }

        public int[,] FieldMatrix
        {
            get { return fieldMatrix; }
        }

        public void AddShapeToField()
        {
            int[,] shapeMatrix = currentShape.ShapeMatrix;
            int shapeRows = shapeMatrix.GetLength(0);
            int shapeCols = shapeMatrix.GetLength(1);

            for (int row = 0; row < shapeRows; row++)
            {
                for (int col = 0; col < shapeCols; col++)
                {
                    if (shapeMatrix[row, col] == 1)
                    {
                        int targetRow = currentShape.Row + row;
                        int targetCol = currentShape.Col + col;

                        if (targetRow >= 0 && targetRow < fieldMatrix.GetLength(0) &&
                            targetCol >= 0 && targetCol < fieldMatrix.GetLength(1))
                        {
                            fieldMatrix[targetRow, targetCol] = 1;
                        }
                    }
                }
            }
            CheckAndClearFullRows();
        }

        public bool CanPlaceShape(Shape shape)
        {
            int[,] shapeMatrix = shape.ShapeMatrix;
            int shapeRows = shapeMatrix.GetLength(0);
            int shapeCols = shapeMatrix.GetLength(1);

            for (int row = 0; row < shapeRows; row++)
            {
                for (int col = 0; col < shapeCols; col++)
                {
                    if (shapeMatrix[row, col] == 1)
                    {
                        int targetRow = shape.Row + row;
                        int targetCol = shape.Col + col;

                        if (targetRow < 0 || targetRow >= fieldMatrix.GetLength(0) ||
                            targetCol < 0 || targetCol >= fieldMatrix.GetLength(1) ||
                            fieldMatrix[targetRow, targetCol] == 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void CheckAndClearFullRows()
        {
            int rows = fieldMatrix.GetLength(0);
            int cols = fieldMatrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                bool isFull = true;
                for (int col = 0; col < cols; col++)
                {
                    if (fieldMatrix[row, col] == 0)
                    {
                        isFull = false;
                        break;
                    }
                }

                if (isFull)
                {
                    ClearRow(row);
                    MoveAllRowsDown(row);
                    score += 100;
                }
            }
        }

        private void ClearRow(int row)
        {
            int cols = fieldMatrix.GetLength(1);
            for (int col = 0; col < cols; col++)
            {
                fieldMatrix[row, col] = 0;
            }
        }

        private void MoveAllRowsDown(int fromRow)
        {
            int cols = fieldMatrix.GetLength(1);
            for (int row = fromRow; row > 0; row--)
            {
                for (int col = 0; col < cols; col++)
                {
                    fieldMatrix[row, col] = fieldMatrix[row - 1, col];
                }
            }

            for (int col = 0; col < cols; col++)
            {
                fieldMatrix[0, col] = 0;
            }
        }

        public void PrintFieldWithShape(Shape shape)
        {
            int rows = fieldMatrix.GetLength(0);
            int cols = fieldMatrix.GetLength(1);

            int[,] tempField = (int[,])fieldMatrix.Clone();
            int[,] shapeMatrix = shape.ShapeMatrix;
            int shapeRows = shapeMatrix.GetLength(0);
            int shapeCols = shapeMatrix.GetLength(1);

            for (int row = 0; row < shapeRows; row++)
            {
                for (int col = 0; col < shapeCols; col++)
                {
                    if (shapeMatrix[row, col] == 1)
                    {
                        int targetRow = shape.Row + row;
                        int targetCol = shape.Col + col;

                        if (targetRow >= 0 && targetRow < rows && targetCol >= 0 && targetCol < cols)
                        {
                            tempField[targetRow, targetCol] = 1;
                        }
                    }
                }
            }

            Console.WriteLine(new string('-', cols + 2) + "  Очки: " + score);

            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(tempField[i, j] == 1 ? "#" : ".");
                }
                Console.WriteLine("|");
            }

            Console.WriteLine(new string('-', cols + 2));
        }

        public void SetCurrentShape(Shape shape)
        {
            currentShape = shape;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = Shape.GetAllShapes();

            GameField gameField = new GameField(20, 10);
            Shape currentShape = shapes[new Random().Next(shapes.Count)];
            currentShape.Row = -2;
            currentShape.Col = 3;
            gameField.SetCurrentShape(currentShape);

            ConsoleKey key;
            bool gameRunning = true;
            int fallSpeed = 500;

            while (gameRunning)
            {
                Console.Clear();
                gameField.PrintFieldWithShape(currentShape);

                if (Console.KeyAvailable)
                {
                    key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            currentShape.Rotate();
                            if (!gameField.CanPlaceShape(currentShape))
                            {
                                currentShape.Rotate();
                                currentShape.Rotate();
                                currentShape.Rotate();
                            }
                            break;
                        case ConsoleKey.LeftArrow:
                            currentShape.MoveLeft();
                            if (!gameField.CanPlaceShape(currentShape))
                            {
                                currentShape.MoveRight();
                            }
                            break;
                        case ConsoleKey.RightArrow:
                            currentShape.MoveRight();
                            if (!gameField.CanPlaceShape(currentShape))
                            {
                                currentShape.MoveLeft();
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            currentShape.MoveDown();
                            if (!gameField.CanPlaceShape(currentShape))
                            {
                                if (currentShape.Row <= -2)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Игра закончена. R для перезапуска или ESC для выхода.");
                                    ConsoleKey endKey = Console.ReadKey(true).Key;
                                    if (endKey == ConsoleKey.R)
                                    {
                                        gameField = new GameField(20, 10);
                                        currentShape = shapes[new Random().Next(shapes.Count)];
                                        currentShape.Row = -2;
                                        currentShape.Col = 3;
                                        gameField.SetCurrentShape(currentShape);
                                        continue;
                                    }
                                    else if (endKey == ConsoleKey.Escape)
                                    {
                                        gameRunning = false;
                                        break;
                                    }
                                }
                                currentShape.Row--;
                                gameField.AddShapeToField();
                                currentShape = shapes[new Random().Next(shapes.Count)];
                                currentShape.Row = -2;
                                currentShape.Col = 3;
                                gameField.SetCurrentShape(currentShape);
                            }
                            break;
                        case ConsoleKey.Spacebar:
                            currentShape.Rotate();
                            if (!gameField.CanPlaceShape(currentShape))
                            {
                                currentShape.Rotate();
                                currentShape.Rotate();
                                currentShape.Rotate();
                            }
                            break;
                        case ConsoleKey.Escape:
                            gameRunning = false;
                            break;
                    }
                }

                Thread.Sleep(fallSpeed);
                currentShape.MoveDown();
                if (!gameField.CanPlaceShape(currentShape))
                {
                    if (currentShape.Row < -2)
                    {
                        Console.Clear();
                        Console.WriteLine("Игра закончена. R для перезапуска или ESC для выхода.");
                        ConsoleKey endKey = Console.ReadKey(true).Key;
                        if (endKey == ConsoleKey.R)
                        {
                            gameField = new GameField(20, 10);
                            currentShape = shapes[new Random().Next(shapes.Count)];
                            currentShape.Row = 0;
                            currentShape.Col = 3;
                            gameField.SetCurrentShape(currentShape);
                            continue;
                        }
                        else if (endKey == ConsoleKey.Escape)
                        {
                            gameRunning = false;
                            break;
                        }
                    }
                    currentShape.Row--;
                    gameField.AddShapeToField();
                    currentShape = shapes[new Random().Next(shapes.Count)];
                    currentShape.Row = 0;
                    currentShape.Col = 3;
                    gameField.SetCurrentShape(currentShape);
                }
            }
        }
    }
}
