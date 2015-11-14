module.exports = function (grunt) {
    grunt.initConfig({
        pkg: grunt.file.readJSON('package.json'),
        less: {
            dev: {
                options: {
                    sourceMap: true,
                    dumpLineNumbers: 'comments',
                    relativeUrls: true,
                    plugins: [
                            new (require('less-plugin-autoprefix'))({ browsers: ["last 2 versions"] })
                    ]
                },
                files: {
                    'Content/bootstrap.css': 'Content/bootstrap/bootstrap.less',
                    'Content/site.css': 'Content/site.less',
                }
            },
            production: {
                options: {
                    compress: true,
                    sourceMap: true,
                    relativeUrls: true,
                    plugins: [
                            new (require('less-plugin-autoprefix'))({ browsers: ["last 2 versions"] })
                    ]
                },
                files: {
                    'Content/bootstrap.min.css': 'Content/bootstrap/bootstrap.less',
                    'Content/site.min.css': 'Content/site.less',
                }
            }
        },

    });

    grunt.loadNpmTasks('grunt-contrib-less');

    grunt.registerTask('default', ['less']);
    grunt.registerTask('production', ['less:production']);
    grunt.registerTask('dev', ['less:dev']);
};

// https://www.orderfactory.com/articles/Bootstrap-LESS-Grunt-VS.html
// cd $(ProjectDir)
// call grunt --no-color