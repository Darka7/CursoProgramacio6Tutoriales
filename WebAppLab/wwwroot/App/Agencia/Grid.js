"use strict";
var AgenciaGrid;
(function (AgenciaGrid) {
    if (MensajeApp != "") {
        Toast.fire({
            icon: "success", title: MensajeApp
        });
    }
    function OnClickEliminar(id) {
        ComfirmAlert("Desea eliminar el registro? ", "Eliminar", "warning", "#3085d6", "#d33")
            .then(function (result) {
            if (result.isConfirmed) {
                window.location.href = "Agencia/Grid?handler=Eliminar&id=" + id;
            }
        });
    }
    AgenciaGrid.OnClickEliminar = OnClickEliminar;
    $("#GridView").DataTable();
})(AgenciaGrid || (AgenciaGrid = {}));
//# sourceMappingURL=Grid.js.map