using System.Web.Optimization;
using BundleTransformer.Core.Resolvers;
using BundleTransformer.Core.Builders;
using BundleTransformer.Core.Orderers;
using BundleTransformer.Core.Transformers;

namespace WebAppVueWebpack
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.IgnoreList.Clear();
            bundles.UseCdn = false;

            // Initialize all of the related builders, transformers, orderers etc.
            var nullBuilder = new NullBuilder();
            var styleTransformer = new StyleTransformer();
            var scriptTransformer = new ScriptTransformer();
            var nullOrderer = new NullOrderer();


            // Replace a default bundle resolver in order to the debugging HTTP-handler
            // can use transformations of the corresponding bundle
            BundleResolver.Current = new CustomBundleResolver();


            // Initialize the common styles bundle
            var commonStylesBundle = new Bundle("~/bundles/style");
            commonStylesBundle.Include(
                "~/Content/main.scss");
            commonStylesBundle.Builder = nullBuilder;
            commonStylesBundle.Transforms.Add(styleTransformer);
            // Add the css minifier
            //commonStylesBundle.Transforms.Add(new CssMinify());
            commonStylesBundle.Orderer = nullOrderer;
            bundles.Add(commonStylesBundle);

            // Initialize the common scripts bundle
            var commonScriptsBundle = new Bundle("~/bundles/scripts");
            commonScriptsBundle.Include(
                "~/Scripts/packages/vue/vue.js",
                //"~/Scripts/packages/vue/vue-router.js",
                "~/Scripts/packages/vue/vue-strap.js",
                "~/Scripts/main.js");
            commonStylesBundle.Builder = nullBuilder;
            commonScriptsBundle.Transforms.Add(scriptTransformer);
            commonScriptsBundle.Orderer = nullOrderer;
            bundles.Add(commonScriptsBundle);

            BundleTable.EnableOptimizations = true;

        }
    }
}
