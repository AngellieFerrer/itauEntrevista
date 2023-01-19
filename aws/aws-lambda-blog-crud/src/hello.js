"use strict";

module.exports.hello = async (event) => {
  // code
  return {
    statusCode: 200,
    body: JSON.stringify(
      {
        message: "Hello world!",
        input: event,
      },
      null,
      2
    ),
  };
};
