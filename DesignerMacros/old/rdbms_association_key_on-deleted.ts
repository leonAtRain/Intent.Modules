(async () => {

let sourceEnd = association.getOtherEnd().typeReference;
if (sourceEnd.getType().getPackage().specialization !== "Domain Package") {
    return;
}

let sourceType = lookup(association.getOtherEnd().typeReference.typeId);
let targetType = lookup(association.typeReference.typeId);
if (sourceType.specialization != "Class" || targetType.specialization != "Class") {
    return;
}
if (targetType && targetType.getMetadata("auto-manage-keys") != "false") {
    targetType.getChildren().filter(x => x.getMetadata("association") == association.id).forEach(x => x.delete());
}
if (sourceType && sourceType.getMetadata("auto-manage-keys") != "false") {
    sourceType.getChildren().filter(x => x.getMetadata("association") == association.id).forEach(x => x.delete());
}

})();