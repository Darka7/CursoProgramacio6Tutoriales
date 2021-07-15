"use strict";
var AgenciaEdit;
(function (AgenciaEdit) {
    var Entity = $("#AppEdit").data("entity");
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,
        },
        methods: {
            RefrescarValidaciones: function () {
                BValidateData(this.Formulario);
            }
        },
        mounted: function () {
            CreateValidator(this.Formulario);
        }
    });
    Formulario.$mount("#AppEdit");
})(AgenciaEdit || (AgenciaEdit = {}));
//# sourceMappingURL=Edit.js.map