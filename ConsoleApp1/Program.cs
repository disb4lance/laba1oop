using ClassLibrary1;
using System.ComponentModel;
using static System.Console;

drobi x = new drobi(2, 5);
//WriteLine(x.Tostring());
drobi y = new drobi(3, 5);
drobi b = x + y;
bool a = x <= y;
WriteLine($"{b.Numerator} {b.Denominator}");
DateTime now = DateTime.Now;

TreeNode root = new TreeNode(1);
TreeNode child1 = new TreeNode(2);
TreeNode child2 = new TreeNode(3);
TreeNode grandchild1 = new TreeNode(4);
TreeNode grandchild2 = new TreeNode(5);
TreeNode grandchild3 = new TreeNode(6);

// структура дерева
root.Children.Add(child1);
root.Children.Add(child2);
child1.Children.Add(grandchild1);
child1.Children.Add(grandchild3);
child2.Children.Add(grandchild2);

root.PrintChildren();

var europ = new EuropData();
var europDecorator = new EuropDecorator(europ);
WriteLine($"europ ({europ.Culture}): {europ.Name} {europ.GetData()}");
WriteLine($"europDecorator: {europDecorator.Name} {europDecorator.GetData()}");



