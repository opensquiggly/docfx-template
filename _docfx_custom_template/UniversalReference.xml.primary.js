var urefCommon = require('./UniversalReference.common.js');
var extension = require('./UniversalReference.extension.js');

exports.transform = function (model) {
  if (extension && extension.preTransform) {
    model = extension.preTransform(model);
  }

  if (urefCommon && urefCommon.transform) {
    model = urefCommon.transform(model);
  }

  model._disableToc = model._disableToc || !model._tocPath || (model._navPath === model._tocPath);

  if (extension && extension.postTransform) {
    model = extension.postTransform(model);
  }

  return model;
}

exports.getOptions = function (model) {
  return {
    "bookmarks": urefCommon.getBookmarks(model)
  };
}