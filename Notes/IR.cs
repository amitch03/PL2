/*IR.cs

the function of IR
includes machine independent opcodes, instructions and operands of IR
*/
using System.Collections.Generics;

class Compiler
{
    public class Symbol
    {
        public String     Name;
        public int        Offset;
    }

    public class LocalSymbol extends Symbol
    {
    }

    public class GlobalSymbol extends Symbol
    {
    }

    public class Register
    {
        public String Name;
    }

    public class Opcode
    {
    }

    public class Operand
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

    public class Instruction
    {
        public Opcode        Opcode;
        public List<Operand> SourceOperandList;
        public List<Operand> DestinationOperandList;
    }
}
