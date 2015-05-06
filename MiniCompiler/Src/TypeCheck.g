tree grammar TypeCheck;

options
{
   tokenVocab=Mini;
   ASTLabelType=CommonTree;
}

@header
{
}

verify : 
   { System.Console.WriteLine("Entered tree walker"); }
;
