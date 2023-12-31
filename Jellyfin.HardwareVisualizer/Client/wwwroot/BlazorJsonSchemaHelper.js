function setModelJsonSchema(modelUri, schema) {
    monaco.languages.json.jsonDefaults.setDiagnosticsOptions({
        validate: true,
        schemas: [{
            uri: "http://myserver/foo-schema.json",
            fileMatch: [modelUri.toString()],
            schema: JSON.parse(schema)
        }]
    });
}