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

public static MiniLexer         Lexer;
public static MiniParser        Parser;
public static CommonTokenStream Tokens;
public static CommonTree        AstRoot;
public static string            FileName;
public static ANTLRFileStream   FileStream;


public static void Main(string[] args)
{
   FileName = args[0];
   FileStream = new ANTLRFileStream(FileName);
   Lexer = new MiniLexer(FileStream);
   Tokens = new CommonTokenStream(Lexer);
   Parser = new MiniParser(Tokens);

   
   
   try
   {
      ProcessCommandLine(args);
	  AstRoot = Parser.ParseProgram();
      // Dump.DumpAst(AstRoot);
      Console.WriteLine(AstRoot.ToStringTree());
   }
   catch (RecognitionException recognitionException)
   {
      Console.WriteLine("exception: {0}", recognitionException);
   }
   
   
}

}


public void ProcessCommandLine(string[] args)
{
	for (int i = 0; i < args.Length; i++) 
	
	{
		string arg = args[i];
		switch (arg) 
		{
			case : "-dumpIL"
			{
				//dumpCFG routine to FileName.il
				break;
			}
			
			default : break;
		}
	}
}