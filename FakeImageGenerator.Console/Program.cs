using CommandLine;

namespace FakeImageGenerator.Console
{
    class Program
    {
        class Options
        {
            [Option('s', "size", Required = true, HelpText = "Fake image size in bytes.")]
            public int SizeInBytes { get; set; }

            [Option('e', "extension", Required = true, HelpText = "Fake image extension. Available extensions are Jpg and Png.")]
            public string Extension { get; set; }

            [Option('t', "type", Required = true, HelpText = "Fake image output path without the file name and extension.")]
            public string OutputPath { get; set; }
        }

        static void Main(string[] args)
        {
            Parser.Default
                .ParseArguments<Options>(args)
              .WithParsed(RunOptions);
        }

        static void RunOptions(Options opts)
        {
            var generator = new Generator();
            generator.Run(opts.SizeInBytes, opts.Extension, opts.OutputPath);
        }
    }
}