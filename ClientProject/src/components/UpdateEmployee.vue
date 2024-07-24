<script setup lang="ts">
    import { Employee } from "../dataStruct/Employee"
    import { ref, onBeforeMount } from "vue"
    import type { Ref } from "vue"
    import { EmployeeService } from "../services/EmployeeService"
    import { useRoute } from "vue-router"
    import routes from "../router"

    let employee: Ref<Employee> = ref(new Employee())
    let employeeService: EmployeeService = new EmployeeService()
    let route = useRoute()

    onBeforeMount(() => {
        GetEmployeeByID(route.params.employeeID as unknown as number)
    })

    function GetEmployeeByID(employeeID: Employee["employeeID"]){{
        employeeService.GetEmployeeByID(employeeID).then(
            response => {
                if(response.status == 200){
                    employee.value = response.data
                }
            }
        )
    }}

    function updateEmployee(employeeID: Employee["employeeID"]) {
        debugger
        employeeService.UpdateEmployee(employeeID, employee.value).then(
            response => {
                debugger
                if (response.status == 200) {
                    routes.push("/home")
                }
            }
        )
    }


</script>

<template>
    <form class="container" @submit.prevent="updateEmployee(employee.employeeID)">
        <div class="row">
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>EmployeeID</label>
                <input class="w-100" v-model="employee.employeeID" disabled />
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>EmployeeName</label>
                <input class="w-100" v-model="employee.employeeName" />
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Salary</label>
                <input class="w-100" v-model="employee.salary" />
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>DateOfJoin</label>
                <input class="w-100" v-model="employee.dateOfJoin" />
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Designation</label>
                <input class="w-100" v-model="employee.designation" />
            </div>
        </div>
        <div class="text-center m-2">
            <button class="btn btn-primary">Update</button>
        </div>
    </form>
</template>