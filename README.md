# JavaSharp

A free Java to C# source code translator, based on ANTLRv4

All new and modified code is available under the GNU Affero GPL version 3.

## Overview

The goal is to research whether it is feasible to automatically convert Java source code to C# source code,
without adding dependencies. The Java source code will rely on the Java Standard Library and the C# source code will
rely on the .NET standard libraries. There will be no Java layer in C#, for example to use statements such as

    using java.util.List;
    
Instead, the Java List interface will probably be translated in the .NET IList interface.

## Bootstrapping

 - The first step in the translation is a Java program that translates Java source code into an XML version of its AST. (done)
 - From the Java AST XML, a structure is created that can both easily translated to C# and that can serve as a symbol table.
 - Then there needs to be a component to translate Java symbols to C# symbols. Hopefully, such a component can be context free.
 - Without the symbol translation, syntactically correct C# can already be produced. With an improving symbol translation less and less Java-like C# code can be automatically produced.
 - If the translation starts to work smoothly, it starts to become increasingly interesting to translate useful Java libraries to C#.
 - When this translator can be used to convert the Java parser source code to C#, the bootstrapping will reach its finish line: a pure .NET Java to C# translator.

A lot of work still needs to be done.
 
## Contributing
 
There is no issue tracker, roadmap, wiki and other organizational stuff like that. You can stop looking for it right now.
If you like the idea behind this project, if you want to know more about it or if you have an idea you wish to share, just get in touch.
We might be able to do something interesting together.

