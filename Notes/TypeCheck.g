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

//actions
//check main 
//check returns
//check EOF
//check struct names
//check IDs
//check comments
//check local dont hide params
//check whitespace

//IF ANY OF THESE FAIL, RETURN ERROR AND PRINT TO SCREEN



