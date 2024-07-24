<script setup lang="ts">
    import { onMounted } from "vue"
    import { Employee } from "../dataStruct/Employee"
    import { EmployeeService } from "../services/EmployeeService"

    let employeeService = new EmployeeService()

    //onMounted(() => {
    //    try {
    //        employeeService.GetAllEmployees()
    //    }
    //    catch (Exception ex) {
    //        alert(ex)
    //    }
    //})


    //onMounted(() => {
    //    employeeService.GetAllEmployees()
    //        .then((response) => {
    //        alert(response.data)
    //    })
    //        .catch((err) => {
    //            alert(err)
    //        })
    //})


    //onMounted(() => {
    //    try {
    //        throwError()
    //    }
    //    catch (err) {
    //        console.log(err);
    //    }
    //})


    onMounted(() => GetAllEmployees())

    async function GetAllEmployees() {
        try {
            debugger
            alert(await employeeService.GetAllEmployees())
        }
        catch (err) {
            debugger
            alert(await err)
        }
    }

    function throwError() {
        throw "how r u"
    }

</script>

<template>
    <h1>
        Error component
    </h1>
</template>