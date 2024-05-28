
<body>
    <h1>Strategy Design Pattern</h1>
    <h2>Scenario</h2>
    <p>
        Imagine a document editor where you can save the document in various formats such as plain text, HTML, or markdown. Each saving strategy implements a different saving algorithm.
    </p>
    <h2>Implementation Steps</h2>
    <ol>
        <li>Define the <code>ISaveStrategy</code> interface with a <code>Save</code> method.</li>
        <li>Implement concrete strategies: <code>PlainTextSaveStrategy</code>, <code>HtmlSaveStrategy</code>, <code>MarkdownSaveStrategy</code>.</li>
        <li>Create a <code>Document</code> class that uses a strategy to save content.</li>
        <li>Implement a client to switch between different saving strategies.</li>
    </ol>
</body>
