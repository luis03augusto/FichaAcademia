#!/usr/bin/env node

var shell = require("shelljs");

var cwd = shell.pwd();
process.chdir(cwd)


var args = process.argv.slice(2);
var command = 'goofoffline "http://fonts.googleapis.com/css?family=' + args + '"';
shell.exec(command);