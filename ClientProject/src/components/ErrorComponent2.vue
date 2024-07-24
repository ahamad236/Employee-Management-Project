<script setup lang="ts">
    import { Employee } from "../dataStruct/Employee"
    import { EmployeeService } from "../services/EmployeeService"
    import { onMounted } from "vue"

    let employeeService = new EmployeeService()

    onMounted(() => GetAllEmployees())

    async function GetAllEmployees() {
        employeeService.GetAllEmployees()
            .then(async (response) => {
                await alert(response.data)
            })
            .catch(async err => {
                await alert(err)
            })
    }


</script>

<template>
    <h1>
        Error component
    </h1>
</template>
