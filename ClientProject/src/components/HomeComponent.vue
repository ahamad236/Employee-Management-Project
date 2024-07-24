<script setup lang="ts">
    import { ref, onMounted, watch } from "vue"
    import type { Ref } from "vue"
    import { Employee } from "../dataStruct/Employee"
    import { EmployeeService } from "../services/EmployeeService"
    import router from "../router"

    let AllEmployees:Ref<Employee> = ref(new Employee());
    let employeeService = new EmployeeService();

    watch(AllEmployees, async () => {
        const response = await employeeService.GetAllEmployees()
        AllEmployees.value = response.data
    },
        { immediate: true }
    )

    function AddEmployee() {
        router.push("/addEmployee")
    }

    async function DeleteEmployee(employeeID: Employee["employeeID"]) {
        await employeeService.DeleteEmployee(employeeID)
    }

    function UpdateEmployee(employeeID: Employee["employeeID"]) {
        router.push("/updateEmployee/"+employeeID)
    }

    // xs <576, sm >= 576, md >= 768, lg >= 992, xl >= 1200, xxl >= 1400


    //#region Old Functionality without watch starts here
    //onMounted(() => getAllEmployees())

    //function getAllEmployees() {
    //    employeeService.GetAllEmployees().then(
    //        response => {
    //            AllEmployees.value = response.data;
    //        }
    //    )
    //}

    //function DeleteEmployee(employeeID: Employee["employeeID"]) {
    //    employeeService.DeleteEmployee(employeeID).then(
    //        response => {
    //            if (response.status == 200) {
    //                getAllEmployees()
    //            }
    //        }
    //    )
    //}
    //#endregion Old Functionality without watch ends here


</script>

<template>
    <h2>Employees List</h2>
    <!--<div class="container">
        <div class="row">
            <div class="col" v-for="(, key) in AllEmployees[0]">
                {{key}}
            </div>
        </div>
        <div class="row m-1" v-for="employee in AllEmployees">
            <div class="col" v-for="value in employee">
                {{value}}
            </div>
            <div class="col-1">
                <button class="btn btn-primary" @click="UpdateEmployee(employee['employeeID'])" >Update</button>
            </div>
            <div class="col-1">
                <button class="btn btn-danger" @click="DeleteEmployee(employee['employeeID'])">Delete</button>
            </div>
        </div>
        <div class="m-2 text-center">
            <button class="btn btn-primary" @click="AddEmployee">
                Add Employee
            </button>
        </div>
    </div>-->


    <!--
        https://getbootstrap.com/docs/4.0/content/tables/
    -->
    <table class="table">
        <thead>
            <tr>
                <th scope="col" v-for="(, key) in AllEmployees[0]">
                    {{key}}
                </th>
            </tr>
        </thead>
        <tbody>
            <tr v-for="employee in AllEmployees">
                <td scope="row" v-for="value in employee">
                    {{value}}
                </td>
                <td>
                    <button class="btn btn-primary" @click="UpdateEmployee(employee['employeeID'])">Update</button>
                </td>
                <td>
                    <button class="btn btn-danger" @click="DeleteEmployee(employee['employeeID'])">Delete</button>
                </td>
            </tr>
        </tbody>
    </table>
    <div class="m-2 text-center">
        <button class="btn btn-primary" @click="AddEmployee">
            Add Employee
        </button>
    </div>



    <!--<table class="table">
        <thead>
            <tr>
                <th scope="col">#</th>
                <th scope="col">First</th>
                <th scope="col">Last</th>
                <th scope="col">Handle</th>
                <th scope="col">First</th>
                <th scope="col">Last</th>
                <th scope="col">Handle</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope="row">1</th>
                <td>Mark</td>
                <td>Otto</td>
                <td>@mdo</td>
                <td>Mark</td>
                <td>Otto</td>
                <td>@mdo</td>
            </tr>
            <tr>
                <th scope="row">2</th>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>@fat</td>
                <td>Jacob</td>
                <td>Thornton</td>
                <td>@fat</td>
            </tr>
            <tr>
                <th scope="row">3</th>
                <td>Larry</td>
                <td>the Bird</td>
                <td>@twitter</td>
                <td>Larry</td>
                <td>the Bird</td>
                <td>@twitter</td>
            </tr>
        </tbody>
    </table>-->

</template>