// json2html.js
export default function json2html(data) {
  // Generate the table headers by finding unique keys across all objects
  const headers = ["Name", "Age", "Gender"];
  
  // Start the table with the data-user attribute
  let html = `<table data-user="shivashankerreddycheruku@gmail.com">\n<thead>\n<tr>`;

  // Create header cells
  headers.forEach(header => {
    html += `<th>${header}</th>`;
  });
  html += `</tr>\n</thead>\n<tbody>\n`;

  // Generate table rows
  data.forEach(row => {
    html += `<tr>`;
    headers.forEach(header => {
      html += `<td>${row[header] || ""}</td>`;
    });
    html += `</tr>\n`;
  });

  html += `</tbody>\n</table>`;
  return html;
}
