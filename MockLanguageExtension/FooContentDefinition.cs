
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.LanguageServer.Client;
using Microsoft.VisualStudio.Utilities;

namespace MockLanguageExtension
{
	#pragma warning disable CS0649 // Field is never assigned to.

	public class FooContentDefinition
	{
		[Export]
		[Name("foo")]
		[BaseDefinition(CodeRemoteContentDefinition.CodeRemoteContentTypeName)]
		internal static ContentTypeDefinition FooContentTypeDefinition;

		[Export]
		[FileExtension(".foo")]
		[ContentType("foo")]
		internal static FileExtensionToContentTypeDefinition FooFileExtensionDefinition;
	}

	#pragma warning restore CS0649
}
