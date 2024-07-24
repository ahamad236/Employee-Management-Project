<script setup lang="ts">
    import { RouterLink } from "vue-router"
</script>

<template>
    <nav>
        <RouterLink to="/home">HOME</RouterLink> |
        <RouterLink to="/aboutUs">ABOUT US</RouterLink> |
        <RouterLink to="/contactUs">CONTACT US</RouterLink> |
        <RouterLink to="/logOut">LOGOUT</RouterLink>
    </nav>
</template>