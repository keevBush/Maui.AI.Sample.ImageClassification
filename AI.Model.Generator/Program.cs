// See https://aka.ms/new-console-template for more information

using AI.Model.Generator.ModelScorer;

string assetsRelativePath = @"../../..";
string assetsPath = GetAbsolutePath(assetsRelativePath);

var tagsTsv = Path.Combine(assetsPath,  "images", "tags.tsv");
var imagesFolder = Path.Combine(assetsPath, "images");
var inceptionPb = Path.Combine(assetsPath, "inception", "tensorflow_inception_graph.pb");
var labelsTxt = Path.Combine(assetsPath, "inception", "imagenet_comp_graph_label_strings.txt");

try
{
    var modelScorer = new TFModelScorer(tagsTsv, imagesFolder, inceptionPb, labelsTxt);
    modelScorer.Score();

}
catch (Exception ex)
{
    Console.WriteLine("ERRROOOOOOORRRRRRRR");
    Console.WriteLine(ex.ToString());
}
static string GetAbsolutePath(string relativePath)
{
    FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
    string assemblyFolderPath = _dataRoot.Directory.FullName;
    string fullPath = Path.Combine(assemblyFolderPath, relativePath);
    return fullPath;
}