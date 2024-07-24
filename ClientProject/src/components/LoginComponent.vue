<script setup lang="ts">
    import { ref } from 'vue'
    import type { Ref } from 'vue'
    import { Admin } from '../dataStruct/Admin'
    import { AdminService } from '../services/AdminService'
    import router from "../router"

    let admin: Ref<Admin> = ref(new Admin())
    let _adminService = new AdminService()


    //function logIn() {
    //    debugger
    //    _adminService.LogIn(admin.value).then(
    //        response => {
    //            alert("AdminName is : " + response.data.adminName + "and Password is : " + response.data.password);
    //        }
    //    );
    //}


    //function logIn() {
    //    debugger
    //    _adminService.LogIn(admin.value).then(response => {
    //        alert("AdminName is : " + response.data.adminName + "and Password is : " + response.data.password);
    //    })
    //    debugger
    //}


    //async function logIn() {
    //    debugger
    //    await axios.get(ApiUrl + "/admins/" + admin.value.AdminName + "/" + admin.value.Password).then(
    //        response => {
    //            alert("AdminName is :" + response.data.adminName + " and Password is : " + response.data.password);
    //        }
    //    )
    //}




    function logIn() {
        debugger
        _adminService.LogIn(admin.value).then(
            response => {
                if (response) {
                    router.push("/home")
                }
            }
        );
    }

</script>

<template>
    <form @submit.prevent="logIn">
        <div class="row text-center">
            <div class="m-1">
                <label class="col-md-1">Admin Name</label>
                <input class="col-md-2" v-model="admin.adminName" />
            </div>
            <div class="m-1">
                <label class="col-md-1">Password</label>
                <input class="col-md-2" type="password" v-model="admin.password" />
            </div>
            <div class="mt-1">
                <button class="btn btn-primary">LogIn</button>
            </div>
        </div>
    </form>
</template>