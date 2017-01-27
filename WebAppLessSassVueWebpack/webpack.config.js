var CopyWebpackPlugin = require('copy-webpack-plugin');
var ContentPath = __dirname + '/Content/packages/';
var ScriptsPath = __dirname + '/Scripts/packages/';
var ImagesPath = __dirname + '/Images/packages/';
var FontsPath = __dirname + '/Fonts/packages/';
var NodeModules = __dirname + '/node_modules/';

module.exports = {
    entry: __dirname + '/Scripts/main.js',
    output: {
        path: __dirname + '/Scripts/packages',
        filename: ".__webpack.bundle.js"
    },
    plugins: [
        new CopyWebpackPlugin([
            //JS
            //{
            //    from: NodeModules + 'bootstrap-sass/assets/javascripts',
            //    to: ScriptsPath + 'bootstrap'
            //},
            {
                from: NodeModules + 'vue/dist/vue.js',
                to: ScriptsPath + 'vue'
            },
            {
                from: NodeModules + 'vue-router/dist/vue-router.js',
                to: ScriptsPath + 'vue'
            },
            {
                from: NodeModules + 'vue-strap/dist/vue-strap.js',
                to: ScriptsPath + 'vue'
            },
            //CSS
            {
                from: NodeModules + 'bootstrap-sass/assets/stylesheets/bootstrap',
                to: ContentPath + 'bootstrap'
            }
            //Images

            //Fonts

        ], {


            // By default, we only copy modified files during
            // a watch or webpack-dev-server build. Setting this
            // to `true` copies all files.
            copyUnmodified: true
        })
    ]
};