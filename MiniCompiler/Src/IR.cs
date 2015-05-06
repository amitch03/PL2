using System.Collections.Generics;

namespace Compiler
{

public class Object
{
   public int UniqueId;

   private static int NextUniqueId = 0;

   public Object()
   {
      Unique = ++NextUniqueId;
   }
   
   public virtual void Dump()
   {
      Console.WriteLine("Compiler.Object.UniqueId: {0}", UniqueId);
   }
}

public class Symbol extends Compiler.Object
{
   public String Name;
   public int    Offset;
   public Type   Type;
}

public class LocalSymbol extends Symbol
{
}

public class GlobalSymbol extends Symbol
{
}

public class SymbolTable extends Compiler.Object
{
   public Enter(Symbol symbol)
   public Symbol LookUp(String name)
}

public class Register extends Compiler.Object
{
   public String Name;
   public int    Index;
}

public class Opcode extends Compiler.Object
{
   public String Name;
   public int    Index;
}

public class Operand extends Compiler.Object
{
   public Operand Next;
}

public class RegisterOperand  extends Operand
{
   public Symbol   Symbol;
   public Register Register;
}

public class MemoryOperand extends Operand
{
   public Symbol   Symbol;
   public Register Register;
   public int      Offset;
}

public class ConstantOperand extends Operand
{
   public int Value;
}

public class Instruction extends Compiler.Object
{
   public Opcode        Opcode;
   public List<Operand> SourceOperandList;
   public List<Operand> DestinationOperandList;
}

public class Field extends Compiler.Object
{
   public string            Name;
   public Symbol            FieldSymbol;
   public Type              Type;
}

public class Type extends Compiler.Object
{
   public string            Name;
   public Symbol            TypeSymbol;
   public List<Field>       FieldList;
}

public class Variable extends Compiler.Object
{
   public string            Name;
   public Type              Type;
   public Symbol            Symbol;
}

public class Function extends Compiler.Object
{
   public string            Name;
   public Type              Type;
   public Symbol            Symbol;
   public List<Instruction> InstructionList;
   public FlowGraph         FlowGraph;
}

public class Program extends Compiler.Object
{
   public string            Name;
   public Symbol            Symbol;
   public List<Variable>    VariableList;
   public List<Type>        TypeList;
   public List<Function>    FunctionList;
}

}
