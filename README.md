# JavaSharp

A free Java to C# source code translator, based on ANTLRv4

All new and modified code is available under the GNU Affero GPL version 3.

## Overview

This project has just started. It is a hobby project.
The goal is to research whether it is feasible to automatically convert Java source code to C# source code,
without adding dependencies. The Java source code will rely on the Java Standard Library and the C# source code will
rely on the .NET standard libraries. There will be no Java layer in C#, for example to use statements such as

    using java.util.List;
    
Instead, the Java List interface will probably be translated in the .NET IList interface.

## Plans

 - The first step in the translation is a Java program that translates Java source code into an XML version of its AST. (done)
 - Step 2 is reading the XML AST in C#
 - Then we will create C# source code. In order to do that, the Roslyn compiler can be used to directly generate the C# AST.
 - With the Roslyn stack, source code can be generated directly from the AST.
 - If the translation starts to work smoothly, it starts to become interesting to translate useful Java libraries to C#.
 - It would be interesing to see performance differences, translation difficulties, ...
 - I'm even more interested in porting the Java program based on ANTLR to C#.
   If the full Java source code of the ANTLR runtime and the generated Java parser can be ported to C#,
   then Java source code can be parsed from a .NET program directly. That would eradicate the need to create the
   XML version of the Java AST.
 
## Contributing
 
Since this is a hobby project, contributions will be informal. There is no issue tracker, roadmap, wiki and things like that.
If you like the idea behind this project or if you have an idea you wish to share, just get in touch.
We might be able to do something interesting together.

If you own a huge load of cash or some kind of funding that you absolutely want to get rid of and you want me to work more seriously on this,
then we can talk.
