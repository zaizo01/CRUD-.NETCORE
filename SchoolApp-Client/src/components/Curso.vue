<template>
<div class="Curso">        
<div class="text-gray-900 bg-gray-200">
<div class="p-4 flex">
<h1 class="text-3xl">Curso</h1>
</div>
        <div class="md:m-4">
        <form class="inline w-full">
          <div class="bg-white shadow-md rounded px-12 pt-6 -pb-2">
            <div class="flex justify-between flex-wrap -mx-3 mb-6">
              <div class=" w-1/3 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2">Grado</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" placeholder="6to" v-model="grado">
              </div>
              <div class=" w-1/3 px-3 mr-56 ">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2">Seccion</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="E" v-model="seccion">
              </div>
            </div>
            <div class="flex justify-between flex-wrap -mx-3 mb-8">
                 <div class=" w-1/3 px-3 -mr-10">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2 " for="grid-last-name">Cant. Estudiantes</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="number" placeholder="27" v-model.number="cantidad">
              </div>
              <div class=" w-1/3 px-3 mr-56">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Prof. Encargado</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Dioris Rojas" v-model="profesor">
              </div>
               <div class="flex items-center justify-between w-1/3 px-3 mb-8 my-5  px-3">
              <button class="bg-blue-500 hover:bg-blue-dark text-white font-bold py-2 px-8 rounded" type="button" @click="AddCurso()">Add</button>
            </div>
            </div>    
        </div>
        </form>
      </div>
      <!-- tabla -->
    <div class="px-3 py-4 flex justify-center">
        <table class="w-full text-md bg-white shadow-md rounded mb-4">
            <tbody>
                <tr class="border-b">
                    <th class="p-3">ID</th>
                    <th class="p-3">Grado</th>
                    <th class="p-3">Seccion</th>
                    <th class="p-3">Cantidad de Estudiantes</th>
                    <th class="p-3">Profesor Encargado</th>
                    <th class="p-3">Acciones</th>
                    <th></th>
                </tr>
                <tr class="border-b hover:bg-orange-100"  v-for="Curso in Cursos" :key="Curso.idCurso">
                    <td class="p-3">{{Curso.idCurso}}</td>
                    <td class="p-3">{{Curso.grado}}</td>
                    <td class="p-3">{{Curso.seccion}}</td>
                    <td class="p-3">{{Curso.cantDeEstudiantes}}</td>
                    <td class="p-3">{{Curso.profesorEncargado}}</td>
                    
                    <td >
                    <button type="button" class="mr-3 text-sm bg-blue-300 hover:bg-blue-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline">Edit</button>
                    <button type="button" class="text-sm bg-red-500 hover:bg-red-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline" @click="deleteCurso(Curso,Curso.idCurso)">Delete</button>
                    </td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
    </div>
</template>


<style>
    
</style>




<script>
import axios from 'axios'
import indexVue from '../../../../Navidad/CRUD/src/components/index.vue'
export default {
    name: 'Curso',
    data() {
      return {
        Cursos: [],
        grado: '',
        seccion: '',
        cantidad: 0,
        profesor:''
      }
    },
    created() {
    fetch('https://localhost:44375/api/Curso')
    .then(response => response.json())
    .then((data) => { this.Cursos = data})
  },
  methods: {
   AddCurso() {
     axios.post('https://localhost:44375/api/Curso', {
      Grado: this.grado,
      Seccion: this.seccion,
      cantDeEstudiantes: this.cantidad,
      profesorEncargado: this.profesor

    })
    .then(function (response) {
      console.log(response);
    })
    .catch(function (error) {
      console.log(error);
    });
    },
    deleteCurso(Cursos,idCurso){
      axios.delete('https://localhost:44375/api/Curso/' + idCurso)
      .then((response => this.Cursos.splice(Cursos,1)));
    }
  }
}
</script>
