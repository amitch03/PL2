# COMMAND LINE MACROS
#
# BUILD         = {RELEASE | DEBUG}
# GRAMMAR_BUILD = { RELEASE | DEBUG | TRACE }
#

!ifndef CALPOLY_ROOT
CALPOLY_ROOT=C:\CalPoly
!endif

!ifndef COMPILER_ROOT
COMPILER_ROOT=C:\CalPoly\MiniCompiler
!endif

!ifndef BUILD
BUILD=DEBUG
!endif

!if "$(BUILD)"=="RELEASE"
BIN_DIR=$(COMPILER_ROOT)\Bin\Release
!elseif "$(BUILD)"=="DEBUG"
BIN_DIR=$(COMPILER_ROOT)\Bin\Debug
!else
!error BUILD must be RELEASE or DEBUG
!endif

!ifndef GRAMMAR_BUILD
GRAMMAR_BUILD=RELEASE
!endif

!if "$(GRAMMAR_BUILD)"=="RELEASE"
ANTLR_OPTIONS=
!elseif "$(GRAMMAR_BUILD)"=="DEBUG"
ANTLR_OPTIONS=-debug
!elseif "$(GRAMMAR_BUILD)"=="TRACE"
ANTLR_OPTIONS=-trace
!else
!error GRAMMAR_BUILD must be RELEASE, DEBUG, or TRACE
!endif

ANTLR=antlr3.exe
CSC=csc.exe
TEST_ROOT=$(CALPOLY_ROOT)\Benchmarks
TEST_COMPILER=$(BIN_DIR)\MiniCompiler.exe

ANTLR_SRC_DIR=.
ANTLR_SRC_FILES=$(ANTLR_SRC_DIR)\MiniParser.cs $(ANTLR_SRC_DIR)\MiniLexer.cs $(ANTLR_SRC_DIR)\TypeCheck.cs
ANTLR_TOKEN_FILES=$(ANTLR_SRC_DIR)\Mini.tokens $(ANTLR_SRC_DIR)\TypeCheck.tokens 
SRC_FILES=Compiler.cs Dump.cs $(ANTLR_SRC_FILES)

CSC_REFERENCES=-reference:C:\CalPoly\ANTLR\ANTLR_3.5.0.2\CSharpRuntime\Antlr3.Runtime.dll
!if "$(BUILD)"=="DEBUG"
CSC_OPTIONS=/nologo /debug:full /optimize- /nowarn:3021 $(CSC_REFERENCES)
!elseif "$(BUILD)"=="RELEASE"
CSC_OPTIONS=/nologo /optimize /nowarn:3021 $(CSC_REFERENCES)
!else
!error BUILD must be RELEASE or DEBUG
!endif

build: gen compile
gen: $(SRC_FILES)
compile: $(BIN_DIR)\MiniCompiler.exe
   
$(ANTLR_SRC_DIR)\MiniLexer.cs $(ANTLR_SRC_DIR)\MiniParser.cs : Mini.g
	$(ANTLR) $(ANTLR_OPTIONS) -o $(ANTLR_SRC_DIR) Mini.g

$(ANTLR_SRC_DIR)\TypeCheck.cs : TypeCheck.g
	$(ANTLR) $(ANTLR_OPTIONS) -o $(ANTLR_SRC_DIR) TypeCheck.g

$(BIN_DIR)\MiniCompiler.exe : $(SRC_FILES)
   $(CSC) $(CSC_OPTIONS) -out:$(BIN_DIR)\MiniCompiler.exe $(SRC_FILES)

clean:
   erase /q $(ANTLR_SRC_FILES)
   erase /q $(ANTLR_TOKEN_FILES)
   erase /q $(COMPILER_ROOT)\Bin\Release\*.*
   erase /q $(COMPILER_ROOT)\Bin\Debug\*.*

test_compiler:
   $(TEST_COMPILER) $(TEST_ROOT)\BenchMarkishTopics\BenchMarkishTopics.mini
   $(TEST_COMPILER) $(TEST_ROOT)\bert\bert.mini
   $(TEST_COMPILER) $(TEST_ROOT)\biggest\biggest.mini
   $(TEST_COMPILER) $(TEST_ROOT)\binaryConverter\binaryConverter.mini
   $(TEST_COMPILER) $(TEST_ROOT)\creativeBenchMarkName\creativeBenchMarkName.mini
   $(TEST_COMPILER) $(TEST_ROOT)\fact_sum\fact_sum.mini
   $(TEST_COMPILER) $(TEST_ROOT)\Fibonacci\Fibonacci.mini
   $(TEST_COMPILER) $(TEST_ROOT)\GeneralFunctAndOptimize\GeneralFunctAndOptimize.mini
   $(TEST_COMPILER) $(TEST_ROOT)\hailstone\hailstone.mini
   $(TEST_COMPILER) $(TEST_ROOT)\hanoi_benchmark\hanoi_benchmark.mini
   $(TEST_COMPILER) $(TEST_ROOT)\killerBubbles\killerBubbles.mini
   $(TEST_COMPILER) $(TEST_ROOT)\mile1\mile1.mini
   $(TEST_COMPILER) $(TEST_ROOT)\mixed\mixed.mini
   $(TEST_COMPILER) $(TEST_ROOT)\OptimizationBenchmark\OptimizationBenchmark.mini
   $(TEST_COMPILER) $(TEST_ROOT)\primes\primes.mini
   $(TEST_COMPILER) $(TEST_ROOT)\programBreaker\programBreaker.mini
   $(TEST_COMPILER) $(TEST_ROOT)\stats\stats.mini
   $(TEST_COMPILER) $(TEST_ROOT)\TicTac\TicTac.mini
   $(TEST_COMPILER) $(TEST_ROOT)\uncreativeBenchmark\uncreativeBenchmark.mini
   $(TEST_COMPILER) $(TEST_ROOT)\wasteOfCycles\wasteOfCycles.mini
