tree grammar SemanticCheck;

options
{
   tokenVocab=Mini;
   ASTLabelType=CommonTree;
}

@header
{

using System;

}

@members
{

public void CheckProgram()
{
   program();
}

}

/*
   Parser Rules
*/

program
   :  ^(PROGRAM t=types d=declarations f=functions EOF)
   ;
types
   :  ^(TYPES types_sub)
   ;
types_sub
   :  type_declaration types_sub
   |
   ;
type_declaration
   :  STRUCT^ ID nested_decl
   ;
nested_decl
   :  (decl)+
   ;
decl
   :  ^(DECL ^(TYPE t=type) i=ID)
   ;
type
   :  INT
   |  BOOL
   |  STRUCT^ ID
   ;
declarations
   :  ^(DECLS declaration*)
   ;
declaration
   : ^(DECLLIST ^(TYPE t=type) ilist=id_list)
   ;
id_list
   :  ID (ID)*
   ;
functions
   :  ^(FUNCS function*)
   ;
function
   : ^(FUN id=ID p=parameters ^(RETTYPE r=return_type) d=declarations s=statement_list RBRACE)
   ;
parameters
   : ^(PARAMS decl*)
   ;
return_type
   :  type
   |  VOID
   ;
statement
   :  block
   |  assignment
   |  print
   |  read
   |  conditional
   |  loop
   |  delete
   |  ret
   |  invocation
   ;
block
   : ^(BLOCK s=statement_list)
   ;
statement_list
   :  ^(STMTS statement*)
   ;
assignment
   :  ^(ASSIGN e=expression l=lvalue)
   ;
print
   :  PRINT^ expression (ENDL)?
   ;
read
   :  READ^ lvalue
   ;
conditional
   :  IF^ expression (THEN^ block) (ELSE^ block)?
   ;
loop
   : ^(WHILE e1=expression b=block e2=expression)
   ;
delete
   :  DELETE^ expression
   ;
ret
   :  ^(RETURN (expression)?)
   ;
invocation
   : ^(INVOKE id=ID a=arguments)
   ;
lvalue
   :  ID (DOT^ ID)*
   ;
expression
   :  boolterm ((AND^ | OR^) boolterm)*
   ;
boolterm
   :  simple ((EQ^ | LT^ | GT^ | NE^ | LE^ | GE^) simple)?
   ;
simple
   :  term ((PLUS^ | MINUS^) term)*
   ;
term
   :  unary ((TIMES^ | DIVIDE^) unary)*
   ;
unary
   :  not
   |  selector
   ;
not
   :  ^(NOT s=selector)
   ;
selector
   :  factor (DOT^ ID)*
   ;
factor
   // :  expression
   :  ^(INVOKE id=ID a=arguments)
   |  ID
   |  INTEGER
   |  TRUE
   |  FALSE
   |  NEW^ ID
   |  NULL
   ;
arguments
   :  arg_list
   ;
arg_list
   :  ^(ARGS expression*)
   ;

