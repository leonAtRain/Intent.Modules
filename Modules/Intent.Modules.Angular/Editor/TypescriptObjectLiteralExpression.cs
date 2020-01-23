using System.Linq;
using Zu.TypeScript.TsTypes;

namespace Intent.Modules.Angular.Editor
{
    public class TypescriptObjectLiteralExpression : TypescriptNode
    {
        public TypescriptObjectLiteralExpression(Node node, TypescriptFile file) : base(node, file)
        {
        }

        public bool PropertyAssignmentExists(string propertyName, string valueLiteral = null)
        {
            var properties = Node.Children.Where(x => x.Kind == SyntaxKind.PropertyAssignment);

            var property = properties.FirstOrDefault(x => x.IdentifierStr == propertyName);
            if (property == null)
            {
                return false;
            }
            return valueLiteral == null || property.Children[1].IdentifierStr == valueLiteral || property.Children[1].GetText() == valueLiteral;
        }

        public void InsertPropertyAssignment(string propertyAssignment, Node afterNode)
        {
            if (afterNode != null)
            {
                if (afterNode.Kind == SyntaxKind.PropertyAssignment)
                {
                    propertyAssignment = $", {propertyAssignment}";
                }
                Change.InsertAfter(afterNode, propertyAssignment);
            }
            else
            {
                if (Node.Children.OfKind(SyntaxKind.PropertyAssignment).Any())
                {
                    InsertPropertyAssignment(propertyAssignment, Node.OfKind(SyntaxKind.PropertyAssignment).LastOrDefault());
                    return;
                }
                Change.InsertBefore(Node.Children.Last(), propertyAssignment);
            }
        }

        public void AddPropertyAssignment(string propertyAssignment)
        {
            InsertPropertyAssignment(propertyAssignment, Node.OfKind(SyntaxKind.PropertyAssignment).LastOrDefault());
        }
    }
}