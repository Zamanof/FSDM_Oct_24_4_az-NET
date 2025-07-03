// Chain of Responsibility

ICompile compile = new SyntaxAnalyzer()
                    .SetNext(new LexicalAnalyzer()
                                .SetNext(new Linker()));

compile.Handle();

Console.WriteLine();

ICompile compile1 = new LexicalAnalyzer()
                        .SetNext(new SyntaxAnalyzer()
                                        .SetNext(new Linker()
                                                .SetNext(new Compiler())));
compile1.Handle();
