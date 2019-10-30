
function setInnerHTML(id, content) {
    document.getElementById(id).innerHTML = content;
}

function setElementVis(id, vis) {
    document.getElementById(id).style.visibility = vis;
}

function createElementNew(type, parentid, childid, content) {
    var newE = document.createElement(type);
    newE.id = childid;
    var node = document.createTextNode(content);
    newE.appendChild(node);
    var element = document.getElementById(parentid);
    element.appendChild(newE);
}