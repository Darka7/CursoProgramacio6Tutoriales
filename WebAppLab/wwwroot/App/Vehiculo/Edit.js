"use strict";
var VehiculoEdit;
(function (VehiculoEdit) {
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
})(VehiculoEdit || (VehiculoEdit = {}));
//# sourceMappingURL=Edit.js.map