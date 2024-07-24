<script setup lang="ts">
    import { RouterView } from "vue-router"
    import Header from "./components/HeaderComponent.vue"
    import Footer from "./components/FooterComponent.vue"
    import NavBar from "./components/NavBarComponent.vue"

    //import Error from "./components/ErrorComponent2.vue"
</script>

<template>
    <Header></Header>
    <main>
        <NavBar v-if=" $route.path != '/' "></NavBar>
        <RouterView></RouterView>
    </main>
    <Footer></Footer>

    <!--<main>
        <Error></Error>
    </main>-->
</template>