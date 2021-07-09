namespace VehiculoEdit {

   
    var Entity = $("#AppEdit").data("entity");
    
    var Formulario = new Vue({
        data: {
            Formulario: "#FormEdit",
            Entity: Entity,

        },

        methods: {
            RefrescarValidaciones() {

                BValidateData(this.Formulario);
            }
        },
        mounted() {
            

            CreateValidator(this.Formulario);
        
        }

    });

    Formulario.$mount("#AppEdit")
}