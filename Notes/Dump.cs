// *************************************************************************************************************
// 
// Compiler
//
// *************************************************************************************************************

using System;
using Antlr.Runtime.Tree;

class Dump
{

public static int IndentLevel = 0;

public static void DumpIndent(int indentLevel)
{
   while (indentLevel != 0)
   {
       Console.Write("   ");
       indentLevel--;
   }
}

public static void DumpAst(CommonTree ast)
{
   DumpIndent(IndentLevel);
   Console.WriteLine(ast.Token.Text);
   DumpAstChildren(ast);
}

public static void DumpAstChildren(CommonTree ast)
{
   if (ast.Children == null)
   {
      return;
   }

   DumpIndent(IndentLevel);
   Console.WriteLine("{");
   IndentLevel++;

   int count = ast.Children.Count;

   for (int i = 0; i < count; ++i)
   {
      CommonTree astChild = (CommonTree)(ast.Children[i]);
      DumpAst(astChild);
   }

   IndentLevel--;
   DumpIndent(IndentLevel);
   Console.WriteLine("}");
}

}

