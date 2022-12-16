<template>
<div id="app">
  <img src="./assets/logo unri.png" height="75">
  <web-toolbar></web-toolbar>
  <router-view/>
  <web-home>
    <web-login></web-login>
  </web-home>
  <web-footer></web-footer>
</div>
</template>

<script>
import WebFooter from './components/WebFooter.vue';
import WebHome from './components/WebHome.vue';
import WebLogin from './components/WebLogin.vue';
import WebToolbar from './components/WebToolbar.vue';


export default {
  name: 'App',

  components: {
    WebFooter, WebHome, WebLogin, WebToolbar
  },

};
</script>
<style lang="scss">
#app {
  font-family: Arial, Helvetica, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: left;
  color: #2c3e50;
}
</style>