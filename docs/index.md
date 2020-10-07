# Happy Docs Sample

This is an example of using the [Markdown Snippets](https://github.com/SimonCropp/MarkdownSnippets) global tool to keep code samples up to date.

## Calculator

The `Calculator` class allows us to do basic arithmetic.

<!-- snippet: calculator-interface -->
<a id='8d733fd1'></a>
```cs
public interface ICalculator
{
    int Add(int x, int y);
    int Minus(int x, int y);
    int Multiply(int x, int y);
    int Divide(int x, int y);
}
```
<sup><a href='Program.cs#L43-L51' title='Snippet source file'>snippet source</a> | <a href='#8d733fd1' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

We can new up a new calculator using the following code.

<!-- snippet: new-calculator -->
<a id='d0e24c7f'></a>
```cs
var calculator = new Calculator();
```
<sup><a href='Program.cs#L9-L11' title='Snippet source file'>snippet source</a> | <a href='#d0e24c7f' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

### Add 

We can add two `int` parameters together.

<!-- snippet: add-example -->
<a id='60d9c190'></a>
```cs
result = calculator.Add(1, 1);
// result is 2
Console.WriteLine(result);
```
<sup><a href='Program.cs#L15-L19' title='Snippet source file'>snippet source</a> | <a href='#60d9c190' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

### Minus

We can add two `minus` parameters together.

<!-- snippet: minus-example -->
<a id='9671badb'></a>
```cs
result = calculator.Minus(1, 1);
// result is 0
Console.WriteLine(result);
```
<sup><a href='Program.cs#L21-L25' title='Snippet source file'>snippet source</a> | <a href='#9671badb' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

### Multiply

We can add two `multiply` parameters together.

<!-- snippet: multiply-example -->
<a id='c5800a3d'></a>
```cs
result = calculator.Multiply(2, 2);
// result is 4
Console.WriteLine(result);
```
<sup><a href='Program.cs#L27-L31' title='Snippet source file'>snippet source</a> | <a href='#c5800a3d' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->

### Divide

We can add two `divide` parameters together.

<!-- snippet: divide-example -->
<a id='b3ea92cb'></a>
```cs
result = calculator.Divide(4, 2);
// result is 2
Console.WriteLine(result);
```
<sup><a href='Program.cs#L34-L38' title='Snippet source file'>snippet source</a> | <a href='#b3ea92cb' title='Start of snippet'>anchor</a></sup>
<!-- endSnippet -->
