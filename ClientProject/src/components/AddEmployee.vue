<script setup lang="ts">
    import { ref, onMounted } from "vue"
    import type { Ref } from "vue"
    import { Employee } from "../dataStruct/Employee"
    import { EmployeeService } from "../services/EmployeeService"
    import router from "../router"

    const employee: Ref<Employee> = ref(new Employee())
    let employeeService = new EmployeeService()

    function AddEmployee() {
        employeeService.AddEmployee(employee.value).then(response => {
            if (response.status == 200) {
                router.push("/home")
            }
        })
    }

    function BackToHome() {
        router.push("/home")
    }

</script>

<template>
    <!--<form class="container" @submit.prevent="AddEmployee" >
        <div class="row">
            <label class="col-xs-5 col-sm-4 col-md-2">Employee ID </label>
            <input class="col-xs-5 col-sm-4 col-md-2" v-model="employee.EmployeeID" />
        </div>
        <div class="row">
            <label class="col-xs-5 col-sm-4 col-md-2">Employee Name </label>
            <input class="col-xs-5 col-sm-4 col-md-2" v-model="employee.EmployeeName" />
        </div>
        <div class="row">
            <label class="col-xs-5 col-sm-4 col-md-2">Salary</label>
            <input class="col-xs-5 col-sm-4 col-md-2" v-model="employee.Salary" />
        </div>
        <div class="row">
            <label class="col-xs-5 col-sm-4 col-md-2">Date Of Join</label>
            <input class="col-xs-5 col-sm-4 col-md-2" v-model="employee.DateOfJoin" />
        </div>
        <div class="row">
            <label class="col-xs-5 col-sm-4 col-md-2">Designation</label>
            <input class="col-xs-5 col-sm-4 col-md-2" v-model="employee.Designation" />
        </div>
        <div class="text-center">
            <button class="btn btn-primary">Add Employee</button>
            <button class="btn btn-danger ms-1" @click="BackToHome">Back To Home</button>
        </div>
    </form>-->
    <!--<form class="container" @submit.prevent="AddEmployee">
        <div class="row">
            <div class="col-xs-5 col-sm-4 col-md-3 m-1">
                <label>Employee ID </label>
                <div>
                    <input v-model="employee.EmployeeID" />
                </div>
            </div>
            <div class="col-xs-5 col-sm-4 col-md-3 m-1">
                <label>Employee Name </label>
                <div>
                    <input v-model="employee.EmployeeName" />
                </div>
            </div>
            <div class="col-xs-5 col-sm-4 col-md-3 m-1">
                <label>Salary</label>
                <div>
                    <input v-model="employee.Salary" />
                </div>
            </div>
            <div class="col-xs-5 col-sm-4 col-md-3 m-1">
                <label>Date Of Join</label>
                <div>
                    <input v-model="employee.DateOfJoin" />
                </div>
            </div>
            <div class="col-xs-5 col-sm-4 col-md-3 m-1">
                <label>Designation</label>
                <div>
                    <input v-model="employee.Designation" />
                </div>
            </div>
        </div>

        <div class="text-center m-2">
            <button class="btn btn-primary">Add Employee</button>
            <button class="btn btn-danger ms-1" @click="BackToHome">Back To Home</button>
        </div>
    </form>-->


    <form class="container" @submit.prevent="AddEmployee">
        <div class="row">
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Employee ID </label>
                <div>
                    <input class="w-100" v-model="employee.employeeID" />
                </div>
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Employee Name </label>
                <div>
                    <input class="w-100" v-model="employee.employeeName" />
                </div>
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Salary</label>
                <div>
                    <input class="w-100" v-model="employee.salary" />
                </div>
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Date Of Join</label>
                <div>
                    <input class="w-100" v-model="employee.dateOfJoin" />
                </div>
            </div>
            <div class="col-6 col-sm-6 col-md-4 col-lg-3">
                <label>Designation</label>
                <div>
                    <input class="w-100" v-model="employee.designation" />
                </div>
            </div>
        </div>

        <div class="text-center m-2">
            <button class="btn btn-primary">Add Employee</button>
            <button class="btn btn-danger ms-1" @click="BackToHome">Back To Home</button>
        </div>
    </form>

</template>