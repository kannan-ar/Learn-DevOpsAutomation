<template>
  <DashboardItem />
</template>

<script lang="ts">
import { Options, Vue } from 'vue-class-component';
import DashboardItem from './components/DashboardItem.vue';

@Options({
  components: {
    DashboardItem,
  },
})
export default class App extends Vue {}
</script>

