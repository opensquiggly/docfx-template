/**
 * This method will be called at the start of exports.transform in RestApi.xml.primary.js
 */
exports.preTransform = function (model) {
  return model;
}

/**
 * This method will be called at the end of exports.transform in RestApi.xml.primary.js
 */
exports.postTransform = function (model) {
  return model;
}