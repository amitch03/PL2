// *************************************************************************************************************
// 
// Compiler
//
// *************************************************************************************************************

using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;
using Antlr.Runtime.Tree;

class Compiler
{

public static MiniLexer            Lexer;
public static MiniParser           Parser;
public static CommonTokenStream    Tokens;
public static CommonTree           AstRoot;
public static string               FileName;
public static ANTLRFileStream      FileStream;
public static CommonTreeNodeStream AstNodes;
public static SemanticCheck        SemanticChecker;

public static void Main(string[] args)
{
   FileName = args[0];
   FileStream = new ANTLRFileStream(FileName);
   Lexer = new MiniLexer(FileStream);
   Tokens = new CommonTokenStream(Lexer);
   Parser = new MiniParser(Tokens);

   try
   {
      AstRoot = Parser.ParseProgram();
      Dump.DumpAst(AstRoot);
      AstNodes = new CommonTreeNodeStream(AstRoot);
      SemanticChecker = new SemanticCheck(AstNodes); 
      SemanticChecker.CheckProgram();
   }
   catch (RecognitionException recognitionException)
   {
      Console.WriteLine("exception: {0}", recognitionException);
   }
}

}


