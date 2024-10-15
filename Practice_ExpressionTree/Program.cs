using System.Linq.Expressions;

namespace Practice_ExpressionTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建原始表达式树x+y
            ParameterExpression x = Expression.Parameter(typeof(int), "x");
            ParameterExpression y = Expression.Parameter(typeof(int), "y");
            BinaryExpression originalExpression = Expression.Add(x, y);

            //编译表达式树并执行
            Func<int, int, int> lambda = Expression.Lambda<Func<int, int, int>>(originalExpression, x, y).Compile();
            Console.WriteLine(lambda(3, 2)); //显示：5

            //遍历并修改表达式树
            SubtractVisitor visitor = new SubtractVisitor();
            BinaryExpression newExpression = (BinaryExpression)visitor.Visit(originalExpression);

            lambda = Expression.Lambda<Func<int, int, int>>(newExpression, x, y).Compile();
            Console.WriteLine(lambda(3, 2)); //显示：1


        }
    }
    //创建自定义ExpressionVisitor
    internal class SubtractVisitor : ExpressionVisitor
    {
        protected override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Add)
            {
                return Expression.Subtract(node.Left, node.Right); // 将Add替换为Subtract
            }
            return base.VisitBinary(node);
        }
    }
}

