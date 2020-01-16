<template>
  <div id="app">
           <div style='border-bottom: 2px solid #eaeaea '>
	<ul class='flex cursor-pointer'>
    <li class='py-2 px-6 bg-white rounded-t-lg text-gray-500 bg-gray-200'><router-link class="nav-link" to="/home">Home</router-link></li>
    <li class='py-2 px-6 bg-white rounded-t-lg '> <router-link class="nav-link" to="/Curso">Curso</router-link></li>
    <li class='py-2 px-6 bg-white rounded-t-lg'> <router-link class="nav-link" to="/Materia">Materia</router-link></li>
    <li class='py-2 px-6 bg-white rounded-t-lg'> <router-link class="nav-link" to="/Estudiante">Estudiante</router-link></li>
	</ul>
</div>
 <router-view/>
  </div>
</template>

<script>
import '../src/assets/style.css'


export default {
  name: 'App' 
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
