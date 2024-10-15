﻿using System.Linq.Expressions;
namespace Practice_ExpressionTree
{

public class Program
    {
        static void Main()
        {
            Expression<Func<int, int, bool>> expression;
            expression = (x, y) => x > y;

            Console.WriteLine("............{0}............", expression);
            PrintNode(expression.Body, 0);

            expression = (x, y) => x * y > x + y;
            Console.WriteLine("............{0}............", expression);
            PrintNode(expression.Body, 0);

        }

        public static void PrintNode(Expression expression, int indent)
        {
            if (expression is BinaryExpression)
                PrintNode(expression as BinaryExpression, indent);
            else
                PrintSingle(expression, indent);
        }

        public static void PrintNode(BinaryExpression expression, int indent)
        {
            PrintNode(expression.Left, indent + 1);
            PrintSingle(expression, indent);
            PrintNode(expression.Right, indent + 1);

        }

        private static void PrintSingle(Expression expression, int indent)
        {
            Console.WriteLine("{0," + indent * 5 + "}{1}", "", NodeToString(expression));
        }

        private static string NodeToString(Expression expression)
        {
            switch (expression.NodeType)
            {
                case ExpressionType.Multiply:
                    return "*";
                case ExpressionType.Divide:
                    return "/";
                case ExpressionType.Add:
                    return "+";
                case ExpressionType.Subtract:
                    return "-";
                case ExpressionType.GreaterThan:
                    return ">";
                case ExpressionType.LessThan:
                    return "<";
                default:
                    return expression.ToString() + "(" + expression.NodeType.ToString() + ")";
            }
        }
    }
}