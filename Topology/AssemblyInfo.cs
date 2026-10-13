Error reading content from DefaultAssemblyInfo.cs:
System.IO.FileNotFoundException: Resource 'SchneiderElectric.TopologyManagerPlugin.Templates.DefaultAssemblyInfo.cs' not found.
   at ICSharpCode.SharpDevelop.EmbeddedResourceFileSystem.OpenRead(FileName fileName)
   at ICSharpCode.SharpDevelop.EmbeddedResourceFileSystem.OpenText(FileName fileName)
   at ICSharpCode.SharpDevelop.ReadOnlyChrootFileSystem.OpenText(FileName fileName)
   at ICSharpCode.SharpDevelop.FileSystemExtensions.ReadAllText(IReadOnlyFileSystem fileSystem, FileName fileName)
   at NxtControl.Studio.Templates.FileDescriptionTemplate..ctor(XmlElement xml, IReadOnlyFileSystem fileSystem)