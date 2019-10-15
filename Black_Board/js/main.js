let name;
let size = 10;

name = window.prompt("Please enter your name");

if (name) {
  for (let i = 0; i < size; i++) {
    document.writeln("<h1> Welcome to the page " + name, "</h1>");
  }
}
